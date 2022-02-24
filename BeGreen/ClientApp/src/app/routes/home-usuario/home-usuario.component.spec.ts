import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { HomeUsuarioComponent } from './home-usuario.component';

describe('HomeUsuarioComponent', () => {
  let component: HomeUsuarioComponent;
  let fixture: ComponentFixture<HomeUsuarioComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ HomeUsuarioComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(HomeUsuarioComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
