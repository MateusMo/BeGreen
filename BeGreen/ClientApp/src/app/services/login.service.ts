import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  loginUrl = 'https://localhost:5001/Login';
  constructor(private http:HttpClient) { }

  login(email:string,senha:string): Observable<any> {
    debugger;
    const headers = { 'content-type': 'application/json'}  
    let options = { headers: headers };
    return this.http.post(`${this.loginUrl}`,options);
  }
}
