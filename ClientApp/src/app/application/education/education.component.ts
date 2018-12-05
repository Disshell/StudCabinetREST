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
  constructor() { }

  ngOnInit() {
    console.log(this.parentForm.controls[3])
    this.parentForm = <FormGroup>this.parentForm.controls[this.formGroupIndex];
  }

}
