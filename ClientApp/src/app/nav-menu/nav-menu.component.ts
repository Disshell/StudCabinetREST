import { AuthService } from './../services/auth.service';
import { Component, DoCheck } from '@angular/core';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})

export class NavMenuComponent implements DoCheck {
  profile: any;

  ngDoCheck(): void {
    if(this.auth.accessToken != ""){
      if (this.auth.userProfile) {
        this.profile = this.auth.userProfile;
      } else {
        this.auth.getProfile((err, profile) => {
          this.profile = profile;
        });
      }
    }
  }

  isExpanded = false;

  constructor(private auth: AuthService){  }

  onClick(){
    this.isExpanded = false;
    if(!this.auth.isAuthenticated()){
      this.auth.login();
    }
    if(this.auth.isAuthenticated()){
      this.auth.logout();
    }
  }

  collapse(){
    this.isExpanded = false;
  }
}
