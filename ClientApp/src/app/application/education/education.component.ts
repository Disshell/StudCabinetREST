import { FormGroup, FormArray, AbstractControl } from '@angular/forms';
import { Component, OnInit, Input} from '@angular/core';

@Component({
  selector: 'app-education',
  templateUrl: './education.component.html',
  styleUrls: ['./education.component.css']
})
export class EducationComponent implements OnInit {
  @Input() parentForm: FormGroup;
  @Input() formGroupIndex: number;
  @Input() listOfInstitutionTypes;
  @Input() listOfCertificateTypes;
  constructor() { }

  ngOnInit() {
    this.parentForm = <FormGroup>this.parentForm.controls[this.formGroupIndex];
  }

}
