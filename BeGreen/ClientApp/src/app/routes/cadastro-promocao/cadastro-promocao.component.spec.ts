import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CadastroPromocaoComponent } from './cadastro-promocao.component';

describe('CadastroPromocaoComponent', () => {
  let component: CadastroPromocaoComponent;
  let fixture: ComponentFixture<CadastroPromocaoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CadastroPromocaoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CadastroPromocaoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
