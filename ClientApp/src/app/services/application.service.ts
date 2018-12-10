import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';

@Injectable()
export class ApplicationService {

  constructor(private http: HttpClient) { }
  
  CreateApplication(application){
    return this.http.post('/api/info/directions', application);
  }

}
