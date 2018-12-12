import { ApplicationService } from './../services/application.service';
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

  ApplicationMainInfo: FormGroup = new FormGroup({
    'name': new FormControl('', Validators.required),
    'Surename': new FormControl('',Validators.required),
    'MiddleName': new FormControl('', Validators.required),
    'Gender': new FormControl('male', Validators.required),
    'DateOfBirth': new FormControl('', Validators.required),
    'Birthplace': new FormControl('', Validators.required),
    'Citizenship': new FormControl('', Validators.required),
    'Phone': new FormControl('', Validators.required),
    'PhoneHome': new FormControl('', Validators.required),
    'Email': new FormControl('', [Validators.required, Validators.email]),
    'Passport': new FormGroup({
      'Series': new FormControl('', Validators.required),
      'Number': new FormControl('', Validators.required),
      'Department': new FormControl('', Validators.required),
      'DateOfIssue': new FormControl('', Validators.required)
    }),
    'AddressPasport': new FormControl('', Validators.required),
    'AddressFact': new FormControl('', Validators.required),
    'Applications' : new FormArray([
       new FormGroup({
          "FacultyId": new FormControl('', Validators.required),
          "DirectionId": new FormControl('', Validators.required),
          "SpecializationId": new FormControl(''),
      })
    ]),
    'Exams' : new FormArray([
      new FormGroup({
        'ObjectId': new FormControl('', Validators.required),
        'Point': new FormControl('', Validators.required)
      })
    ]),
    'totalPoint': new FormControl('0'),
    'Rewards': new FormArray([
      new FormGroup({
        'Name': new FormControl('')
      })
    ]),
    'Educations': new FormArray([
      new FormGroup({
        'InstitutionTypeId': new FormControl('', Validators.required),
        'CertificateTypeId': new FormControl('', Validators.required),
        'InstitutionName': new FormControl('', Validators.required),
        'Point': new FormControl('', Validators.required)
      })
    ]),
    'Privileges': new FormArray([
      new FormGroup({
        'PrivilegeId': new FormControl('', Validators.required),
        'Name': new FormControl('', Validators.required)
      })
    ]),
    'Military': new FormGroup({
      'City': new FormControl('', Validators.required),
      'Name': new FormControl('', Validators.required)
    })
  }
);

  constructor(private infoService: InfoService, private applicationService: ApplicationService) { }

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
    console.log("click");
    this.applicationService.CreateApplication(this.ApplicationMainInfo.value).subscribe(
      res => console.log(res)
    );
  }

  onAddEducation(){
    let ed = new FormGroup({
      'InstitutionTypeId': new FormControl('', Validators.required),
      'CertificateTypeId': new FormControl('', Validators.required),
      'InstitutionName': new FormControl('', Validators.required),
      'Point': new FormControl('', Validators.required)
    });
    //ed.setParent(this.applicationForm);
    (this.ApplicationMainInfo.controls['Educations'] as FormArray).push(ed);
  }

  onAddExam(){
    let ex = new FormGroup({
      'ObjectId': new FormControl('', Validators.required),
      'Point': new FormControl('', Validators.required)
    });
    (this.ApplicationMainInfo.controls['Exams'] as FormArray).push(ex);
  }

  onAddDirection(){
    let dir = new FormGroup({
      "FacultyId": new FormControl('', Validators.required),
      "DirectionId": new FormControl('', Validators.required),
      "SpecializationId" : new FormControl('')
    });
    (this.ApplicationMainInfo.controls['Applications'] as FormArray).push(dir);
  }

  onAddReward(){
    let dir = new FormGroup({
      "Name": new FormControl('', Validators.required),
    });
    (this.ApplicationMainInfo.controls['Rewards'] as FormArray).push(dir);
  }
}
