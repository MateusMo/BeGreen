import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CarbonoComponent } from './carbono.component';

describe('CarbonoComponent', () => {
  let component: CarbonoComponent;
  let fixture: ComponentFixture<CarbonoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CarbonoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CarbonoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
