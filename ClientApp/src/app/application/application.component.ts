import { AuthService } from './../services/auth.service';
import { ApplicationService } from './../services/application.service';
import { InfoService } from './../services/info.service';
import { Component, OnInit, DoCheck } from '@angular/core';
import { FormGroup, FormControl, Validators, FormArray } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-application',
  templateUrl: './application.component.html',
  styleUrls: ['./application.component.css']
})
export class ApplicationComponent implements OnInit, DoCheck {

  applicationMainInfo: FormGroup = new FormGroup({
    'name': new FormControl('', Validators.required),
    'surename': new FormControl('',Validators.required),
    'middleName': new FormControl('', Validators.required),
    'gender': new FormControl('', Validators.required),
    'dateOfBirth': new FormControl('', Validators.required),
    'birthplace': new FormControl('', Validators.required),
    'citizenship': new FormControl('', Validators.required),
    'phone': new FormControl('', [Validators.required, Validators.pattern(/^((\+7)+([0-9]){10})$/)]),
    'phoneHome': new FormControl('', Validators.required),
    'email': new FormControl('', [Validators.required, Validators.email]),
    'needOfHostel': new FormControl('', Validators.required),
    'language': new FormControl('', Validators.required),
    'passport': new FormGroup({
      'series': new FormControl('', [Validators.required, Validators.pattern(/1234/)]),
      'number': new FormControl('', [Validators.required, Validators.pattern(/123456/)]),
      'department': new FormControl('', Validators.required),
      'dateOfIssue': new FormControl('', Validators.required)
    }),
    'addressPasport': new FormControl('', Validators.required),
    'addressFact': new FormControl('', Validators.required),
    'applications' : new FormArray([
       new FormGroup({
          "facultyId": new FormControl('', Validators.required),
          "directionId": new FormControl('', Validators.required),
          "specializationId": new FormControl(''),
      })
    ]),
    'exams' : new FormArray([
      new FormGroup({
        'objectId': new FormControl('', Validators.required),
        'point': new FormControl('', Validators.required)
      })
    ]),
    'rewards': new FormArray([
      new FormGroup({
        'name': new FormControl('')
      })
    ]),
    'educations': new FormArray([
      new FormGroup({
        'institutionTypeId': new FormControl('', Validators.required),
        'certificateTypeId': new FormControl('', Validators.required),
        'institutionName': new FormControl('', Validators.required),
        'point': new FormControl('', Validators.required)
      })
    ]),
    'privileges': new FormArray([
      new FormGroup({
        'name': new FormControl('')
      })
    ]),
    'military': new FormGroup({
      'city': new FormControl('', Validators.required),
      'name': new FormControl('', Validators.required),
      'group': new FormControl('', Validators.required)
    })
  }
);

  constructor(private infoService: InfoService,
    private applicationService: ApplicationService,
    private auth: AuthService,
    private route: ActivatedRoute,
    private router: Router,
    ) { 

      route.params.subscribe( p => {
        this.authId = p['authId']
      });

  }

  authId: string;
  profile: any;
  objects;
  certificateTypes;
  institutionTypes;
  faculties;
  directions;
  specializations;

  ngOnInit() {
    if(this.route.routeConfig.path == "application/:auth"){
      this.applicationService.GetApplicationByAuthId().subscribe(
        a => {
          for(var i = 0 ; i<(a['exams'].length-1); i++){
            this.onAddExam();
          }
          for(var i = 0 ; i<(a['applications'].length-1); i++){
            this.onAddDirection();
          }
          for(var i = 0 ; i<(a['educations'].length-1); i++){
            this.onAddEducation();
          }
          for(var i = 0 ; i<(a['privileges'].length-1); i++){
            this.onAddPrivilege();
          }
          for(var i = 0 ; i<(a['rewards'].length-1); i++){
            this.onAddReward();
          }
          this.applicationMainInfo.patchValue(a);
        }
      );
    }

    this.infoService.GetObjects()
    .subscribe(res => this.objects = res);

    this.certificateTypes = this.infoService.GetСertificatetypes()
    .subscribe( res => this.certificateTypes = res);

    this.institutionTypes = this.infoService.GetInstitutiontypes()
    .subscribe( res => this.institutionTypes = res);

    this.faculties = this.infoService.GetFaculties()
    .subscribe(res => this.faculties = res);

    this.directions = this.infoService.GetDierection()
    .subscribe(res => {this.directions = res});
    
    this.specializations = this.infoService.GetSpecializations()
    .subscribe(res => this.specializations = res);
  }

  ngDoCheck(): void {
    if(this.auth.accessToken != ""){
      if (this.auth.userProfile) {
        this.profile = this.auth.userProfile;
      } else {
        this.auth.getProfile((err, profile) => {
          this.profile = profile;
        });
      }
    }
  }


  onSubmit(){
~    console.log(this.route.routeConfig.path);
    if(this.route.routeConfig.path == "application/new"){
      var date = new Date();
      this.applicationMainInfo.value["authId"] = this.auth.userProfile["sub"];
      this.applicationMainInfo.value["dateOfApplication"] =  "";
      this.applicationMainInfo.value["status"] = "Обрабатыватся";
      console.log(this.applicationMainInfo.value);
      this.applicationService.CreateApplication(this.applicationMainInfo.value).subscribe(res => console.log(res))
    }
    else if(this.route.routeConfig.path == "application/:auth"){
      this.applicationMainInfo.value["dateOfApplication"] = "";
      this.applicationMainInfo.value["status"] = "Обрабатыватся";
      console.log(this.applicationMainInfo.value);
      this.applicationService.EditApplicationByAuthId(this.applicationMainInfo.value, this.profile['sub'] ).subscribe(
      res => console.log(res))
    }
  }

  onAddEducation(){
    let ed = new FormGroup({
      'institutionTypeId': new FormControl('', Validators.required),
      'certificateTypeId': new FormControl('', Validators.required),
      'institutionName': new FormControl('', Validators.required),
      'point': new FormControl('', Validators.required)
    });
    (this.applicationMainInfo.controls['educations'] as FormArray).push(ed);
  }

  onRemoveEducation(index: number){
    const control = <FormArray>this.applicationMainInfo.controls.educations;
    control.removeAt(index);
    //this.directionCount--;
  }

  onAddExam(){
    let ex = new FormGroup({
      'objectId': new FormControl('', Validators.required),
      'point': new FormControl('', Validators.required)
    });
    (this.applicationMainInfo.controls['exams'] as FormArray).push(ex);
  }
  onRemoveExam(index: number){
    const control = <FormArray>this.applicationMainInfo.controls.exams;
    control.removeAt(index);
  }

  onAddDirection(){
    let dir = new FormGroup({
      "facultyId": new FormControl('', Validators.required),
      "directionId": new FormControl('', Validators.required),
      "specializationId" : new FormControl('')
    });
    (this.applicationMainInfo.controls['applications'] as FormArray).push(dir);
  }
  onRemoveDirection(index: number){
    const control = <FormArray>this.applicationMainInfo.controls.applications;
    control.removeAt(index);
  }

  onAddReward(){
    let rwd = new FormGroup({
      "name": new FormControl(''),
    });
    (this.applicationMainInfo.controls['rewards'] as FormArray).push(rwd);
  }

  onRemoveReward(index: number){
    const control = <FormArray>this.applicationMainInfo.controls.rewards;
    control.removeAt(index);
  }

  onAddPrivilege(){
    let prv = new FormGroup({
      "name": new FormControl(''),
    });
    (this.applicationMainInfo.controls['privileges'] as FormArray).push(prv);
  }

  onRemovePrivilege(index: number){
    const control = <FormArray>this.applicationMainInfo.controls.privileges;
    control.removeAt(index);
  }
}
