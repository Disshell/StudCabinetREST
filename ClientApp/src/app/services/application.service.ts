import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable()
export class ApplicationService {

  constructor(private http: HttpClient) { }
  
  CreateApplication(application){
    console.log(JSON.stringify(application));
    let headers = new HttpHeaders();
    headers.append('Content-Type', 'application/JSON');
    return this.http.post('/api/applications', application, {headers});
  }

  GetApplication(){
    return this.http.get('/api/applications');
  }

}
