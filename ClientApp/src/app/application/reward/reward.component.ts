import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-reward',
  templateUrl: './reward.component.html',
  styleUrls: ['./reward.component.css']
})
export class RewardComponent implements OnInit {

  @Input() parentForm: FormGroup;
  @Input() formGroupIndex: number;
  @Output() removedReward= new EventEmitter<number>();
  
  constructor() { }

  ngOnInit() {
    this.parentForm = <FormGroup>this.parentForm.controls[this.formGroupIndex];
  }

  removeReward(){
    this.removedReward.emit(this.formGroupIndex);
  }
}
