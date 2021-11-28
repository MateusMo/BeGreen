import { Component, OnInit } from '@angular/core';
import { login } from '../Models/login';
import { LoginService } from '../services/login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  email:string;
  senha:string;
  login:login = new login();
  constructor(private _loginService:LoginService) { }

  ngOnInit() {
  }

  logar(){
    debugger;
    this.login.email = this.email;
    this.login.senha = this.senha
    this._loginService.login(this.login).subscribe(response => {
      alert('foi')
    },error => {
      alert('n foi')
    })
  }

}
