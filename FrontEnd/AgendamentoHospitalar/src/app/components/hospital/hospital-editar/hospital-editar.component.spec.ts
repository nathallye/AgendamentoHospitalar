import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HospitalEditarComponent } from './hospital-editar.component';

describe('HospitalEditarComponent', () => {
  let component: HospitalEditarComponent;
  let fixture: ComponentFixture<HospitalEditarComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HospitalEditarComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HospitalEditarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
