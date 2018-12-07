import { map } from 'rxjs/operators';
import { InfoService } from './../services/info.service';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators, FormArray } from '@angular/forms';

@Component({
  selector: 'app-application',
  templateUrl: './application.component.html',
  styleUrls: ['./application.component.css']
})
export class ApplicationComponent implements OnInit {

  applicationForm: FormGroup = new FormGroup({
    'firstName': new FormControl('', Validators.required),
    'sureName': new FormControl('',Validators.required),
    'middleName': new FormControl('', Validators.required),
    'gender': new FormControl('male', Validators.required),
    'dateOfBirth': new FormControl('', Validators.required),
    'birthplace': new FormControl('', Validators.required),
    'citizenship': new FormControl('', Validators.required),
    'phone': new FormControl('', Validators.required),
    'homePhone': new FormControl('', Validators.required),
    'email': new FormControl('', [Validators.required, Validators.email]),
    'passport': new FormGroup({
      'passportSeries': new FormControl('', Validators.required),
      'passportNumber': new FormControl('', Validators.required),
      'passportDepartment': new FormControl('', Validators.required),
      'passportDate': new FormControl('', Validators.required)
    }),
    'regAddress': new FormControl('', Validators.required),
    'factAddress': new FormControl('', Validators.required),
    'directions' : new FormArray([
       new FormGroup({
          "facultyId": new FormControl('', Validators.required),
          "directionId": new FormControl('', Validators.required),
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
        'rewardType': new FormControl('', Validators.required),
        'rewardName': new FormControl('', Validators.required)
      })
    ]),
    'educations': new FormArray([
      new FormGroup({
        'institutionTypeId': new FormControl('', Validators.required),
        'certificateTypeId': new FormControl('', Validators.required),
        'educationName': new FormControl('', Validators.required),
        'avgPoint': new FormControl('', Validators.required)
      })
    ]),
    'privileges': new FormArray([
      new FormGroup({
        'rewardType': new FormControl('', Validators.required),
        'rewardName': new FormControl('', Validators.required)
      })
    ]),
    'military': new FormGroup({
      'militaryStatus': new FormControl('',Validators.required),
      'militaryCity': new FormControl('', Validators.required),
      'militaryName': new FormControl('', Validators.required)
    })
  }
);

  constructor(private infoService: InfoService) { }

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


  onSubmit(){
    console.log(this.applicationForm);
  }

  onAddEducation(){
    let ed = new FormGroup({
      'institutionTypeId': new FormControl('', Validators.required),
      'certificateTypeId': new FormControl('', Validators.required),
      'educationName': new FormControl('', Validators.required),
      'avgPoint': new FormControl('', Validators.required)
    });
    //ed.setParent(this.applicationForm);
    (this.applicationForm.controls['educations'] as FormArray).push(ed);
  }

  onAddExam(){
    let ex = new FormGroup({
      'objectId': new FormControl('', Validators.required),
      'point': new FormControl('', Validators.required)
    });
    // ex.setParent(this.applicationForm);
    (this.applicationForm.controls['exams'] as FormArray).push(ex);
  }

  onAddDirection(){
    let dir = new FormGroup({
      "facultyId": new FormControl('', Validators.required),
      "directionId": new FormControl('', Validators.required),
    });
    // ex.setParent(this.applicationForm);
    (this.applicationForm.controls['directions'] as FormArray).push(dir);
  }
}
