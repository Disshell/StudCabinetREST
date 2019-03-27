import { AuthService } from './../services/auth.service';
import { Component } from '@angular/core';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;
  constructor(public auth: AuthService){  }

  onClick(){
    console.log("click")
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
