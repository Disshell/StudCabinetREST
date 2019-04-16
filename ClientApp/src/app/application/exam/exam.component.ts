import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-exam',
  templateUrl: './exam.component.html',
  styleUrls: ['./exam.component.css']
})
export class ExamComponent implements OnInit {
  @Input() parentForm: FormGroup;
  @Input() formGroupIndex: number;
  @Input() listOfObjects;
  @Output() removedExam = new EventEmitter<number>();
  constructor() { }

  ngOnInit() {
    this.parentForm = <FormGroup>this.parentForm.controls[this.formGroupIndex];
  }

  removeExam(){
    this.removedExam.emit(this.formGroupIndex);
  }
}
