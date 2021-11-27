import { Component, OnInit } from '@angular/core';
import { usuario } from '../Models/usuario';

@Component({
  selector: 'app-cadastro',
  templateUrl: './cadastro.component.html',
  styleUrls: ['./cadastro.component.css']
})
export class CadastroComponent implements OnInit {
  usuario:usuario = new usuario();
  constructor() { }

  ngOnInit() {
  }

}
