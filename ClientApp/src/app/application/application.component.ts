import { InfoService } from './../services/info.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-application',
  templateUrl: './application.component.html',
  styleUrls: ['./application.component.css']
})
export class ApplicationComponent implements OnInit {

  constructor(private infoService: InfoService) { }

  ngOnInit() {
  }

  onSubmit(){
    this.infoService.GetDierection()
    .subscribe(res => console.log(res));
  }

}
