import { AuthService } from './../services/auth.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})

export class NavMenuComponent {

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
