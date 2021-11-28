import { Component, OnInit } from '@angular/core';
import { LoginService } from '../services/login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  email:string;
  senha:string;
  constructor(private _loginService:LoginService) { }

  ngOnInit() {
  }

  logar(){
    debugger;
    this._loginService.login(this.email,this.senha).subscribe(response => {
      alert('foi')
    },error => {
      alert('n foi')
    })
  }

}
