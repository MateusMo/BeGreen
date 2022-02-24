import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { login } from '../Models/login'; 

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  loginUrl = 'https://localhost:5001/Login';
  constructor(private http:HttpClient) { }

  login(login:login): Observable<any> {
    const headers = { 'content-type': 'application/json'}  
    const body = login;
    return this.http.post(this.loginUrl, body,{'headers':headers})
  }

  
}
