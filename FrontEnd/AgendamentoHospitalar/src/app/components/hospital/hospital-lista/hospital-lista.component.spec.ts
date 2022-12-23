import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HospitalListaComponent } from './hospital-lista.component';

describe('HospitalListaComponent', () => {
  let component: HospitalListaComponent;
  let fixture: ComponentFixture<HospitalListaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HospitalListaComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HospitalListaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
