import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable()
export class ApplicationService {

  constructor(private http: HttpClient) { }
  
  CreateApplication(applicationMainInfo){
    let headers = new HttpHeaders();
    headers.append('Content-Type', 'application/JSON');
    return this.http.post('/api/applications', applicationMainInfo, {headers});
  }

  GetApplication(){
    return this.http.get('/api/applications');
  }

}
