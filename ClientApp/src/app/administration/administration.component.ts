import { ApplicationService } from './../services/application.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-administration',
  templateUrl: './administration.component.html',
  styleUrls: ['./administration.component.css']
})
export class AdministrationComponent implements OnInit {

  applications;
  constructor(private applicationService: ApplicationService) { }

  ngOnInit() {
    this.applicationService.GetApplication().subscribe(
      res => this.applications = res
    );
  }

  onClick(){
    console.log(this.applications);
  }

}
