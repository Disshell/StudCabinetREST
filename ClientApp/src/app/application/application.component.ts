import { AuthService } from './../services/auth.service';
import { ApplicationService } from './../services/application.service';
import { InfoService } from './../services/info.service';
import { Component, OnInit, DoCheck } from '@angular/core';
import { FormGroup, FormControl, Validators, FormArray } from '@angular/forms';

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
    'totalPoint': new FormControl('0'),
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

  constructor(private infoService: InfoService, private applicationService: ApplicationService, private auth: AuthService) { }

  profile: any;
  objects;
  certificateTypes;
  institutionTypes;
  faculties;
  directions;
  specializations; 

  ngOnInit() {
    this.infoService.GetObjects()
    .subscribe(res => this.objects = res);

    this.certificateTypes = this.infoService.GetСertificatetypes()
    .subscribe( res => this.certificateTypes = res);

    this.institutionTypes = this.infoService.GetInstitutiontypes()
    .subscribe( res => this.institutionTypes = res);

    this.faculties = this.infoService.GetFaculties()
    .subscribe(res => this.faculties = res);

    this.directions = this.infoService.GetDierection()
    .subscribe(res => this.directions = res);
    
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
    console.log(this.applicationMainInfo);
    this.applicationService.CreateApplication(this.applicationMainInfo.value).subscribe(
      res => console.log(res)
    );
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

  onAddExam(){
    let ex = new FormGroup({
      'objectId': new FormControl('', Validators.required),
      'point': new FormControl('', Validators.required)
    });
    (this.applicationMainInfo.controls['exams'] as FormArray).push(ex);
  }

  onAddDirection(){
    let dir = new FormGroup({
      "facultyId": new FormControl('', Validators.required),
      "directionId": new FormControl('', Validators.required),
      "specializationId" : new FormControl('')
    });
    (this.applicationMainInfo.controls['applications'] as FormArray).push(dir);
  }

  onAddReward(){
    let dir = new FormGroup({
      "name": new FormControl(''),
    });
    (this.applicationMainInfo.controls['rewards'] as FormArray).push(dir);
  }

  onAddPrivilege(){
    let dir = new FormGroup({
      "name": new FormControl(''),
    });
    (this.applicationMainInfo.controls['privileges'] as FormArray).push(dir);
  }

  onClick(){
    console.log(this.auth.idToken)
    console.log(this.auth.accessToken)
  }

}
