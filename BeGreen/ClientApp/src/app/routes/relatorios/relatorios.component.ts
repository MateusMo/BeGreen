import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-relatorios',
  templateUrl: './relatorios.component.html',
  styleUrls: ['./relatorios.component.css']
})
export class RelatoriosComponent implements OnInit {
  chooseReport:string = '';
  constructor() { }

  ngOnInit() {
  }

  setReport(){
    let reportType = (<HTMLInputElement>document.getElementById("inputState1")).value;
    debugger;
    switch ( reportType ) {
      case 'Usuario':
          this.chooseReport = 'usuario'
          break;
      case '':
          // statement 2
          break;
      case '':
          // statement N
          break;
      default: 
          // 
          break;
   }
  }

}
