import { Application } from './../../../models/application';
import { ApplicationService } from './../services/application.service';
import { AuthService } from './../services/auth.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-status',
  templateUrl: './status.component.html',
  styleUrls: ['./status.component.css']
})
export class StatusComponent implements OnInit {

  constructor(private auth: AuthService,
    private ApplicationService: ApplicationService,
    private router: Router
    ) { }

  profile: any;
  date: Date;
  status: string;
  application: any;

  ngDoCheck(): void {
    if (this.auth.userProfile) {
      this.profile = this.auth.userProfile;
    } else {
      this.auth.getProfile((err, profile) => {
        this.profile = profile;
      });
    }
  } 

  ngOnInit() {
    this.ApplicationService.GetApplicationByAuthId().subscribe( res => { 
      this.application = res
      this.status = this.application["status"];
      console.log(this.application);
    } );
  }
  
  onClick() {
    this.router.navigate(['/application/' +  this.profile['sub']])
  }


}
