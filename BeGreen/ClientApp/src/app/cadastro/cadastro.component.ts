import { Component, OnInit } from '@angular/core';
import { parceiro } from '../Models/parceiro';
import { usuario } from '../Models/usuario';

@Component({
  selector: 'app-cadastro',
  templateUrl: './cadastro.component.html',
  styleUrls: ['./cadastro.component.css']
})
export class CadastroComponent implements OnInit {

  //objetos e propriedades auxiliares
  usuario:usuario = new usuario();
  parceiro:parceiro = new parceiro();
  email:string;
  senha:string;

  //lógica de ngIf
  isBusiness:any = null;
  hideNext:boolean = false;

  constructor() { }

  ngOnInit() {
  }

  finalizarCadastro(){
    debugger;
    this.hideNext = true;
    //verifica se é usuário ou parceiro
    this.isBusiness = (<HTMLInputElement>document.getElementById("inputState")).value;
    // //verifica gênero do usuário
    // let genero = (<HTMLInputElement>document.getElementById("inputStateGenero")).value;
    // if(genero == 'Masculino'){
    //   this.usuario.genero = 0;
    // } else if(genero == 'Feminino') {
    //   this.usuario.genero = 1;
    // }else if(genero == 'Outro'){
    //   this.usuario.genero = 2
    // }
     
    this.isBusiness == 'Usuário' ? this.isBusiness = 0 : this.isBusiness = 1;
    this.hideNext = true;
  }

}
