import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable, OnInit } from '@angular/core';
import { AuthService } from './auth.service';

@Injectable()
export class ApplicationService {

  constructor(private http: HttpClient, private auth: AuthService){}
  
  CreateApplication(applicationMainInfo){
    let headers = new HttpHeaders(
      {
        "Content-Type": "application/JSON",
        "Authorization": "Bearer " + this.auth.accessToken
      }
    );
    //headers.set('Content-Type', 'application/JSON');
    //headers.append('Authorization', "Bearer " + this.auth.accessToken)
    return this.http.post('/api/applications', applicationMainInfo, { headers });
  }

  GetApplications(){
    let headers = new HttpHeaders(
      {
        "Content-Type": "application/JSON",
        "Authorization": "Bearer " + this.auth.accessToken
      }
    );
    return this.http.get('/api/applications', {headers});
  }

  GetApplicationByAuthId(){
    let headers = new HttpHeaders(
      {
        "Content-Type": "application/JSON",
        "Authorization": "Bearer " + this.auth.accessToken
      }
    );
    return this.http.get('/api/applications/' +  this.auth.userProfile["sub"] , {headers});
  }
  

}
