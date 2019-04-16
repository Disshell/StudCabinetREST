import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-direction',
  templateUrl: './direction.component.html',
  styleUrls: ['./direction.component.css']
})
export class DirectionComponent implements OnInit {

  @Input() parentForm: FormGroup;
  @Input() formGroupIndex: number;
  @Input() listOfFaculties;
  @Input() listOfDirections;
  @Output() removedDirection = new EventEmitter<number>();
  constructor() { }

  ngOnInit() {
    this.parentForm = <FormGroup>this.parentForm.controls[this.formGroupIndex];
  }

  removeDirection(){
    this.removedDirection.emit(this.formGroupIndex);
  }

}
