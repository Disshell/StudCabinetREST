import { Component, OnInit, Input } from '@angular/core';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-reward',
  templateUrl: './reward.component.html',
  styleUrls: ['./reward.component.css']
})
export class RewardComponent implements OnInit {

  @Input() parentForm: FormGroup;
  @Input() formGroupIndex: number;
  
  constructor() { }

  ngOnInit() {
    this.parentForm = <FormGroup>this.parentForm.controls[this.formGroupIndex];
  }

}
