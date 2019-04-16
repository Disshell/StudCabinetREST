import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-privilege',
  templateUrl: './privilege.component.html',
  styleUrls: ['./privilege.component.css']
})
export class PrivilegeComponent implements OnInit {

  @Input() parentForm: FormGroup;
  @Input() formGroupIndex: number;
  @Output() removedPrivilege = new EventEmitter<number>();
  
  constructor() { }

  ngOnInit() {
    this.parentForm = <FormGroup>this.parentForm.controls[this.formGroupIndex];
  }

  removePrivilege(){
    this.removedPrivilege.emit(this.formGroupIndex);
  }
}
