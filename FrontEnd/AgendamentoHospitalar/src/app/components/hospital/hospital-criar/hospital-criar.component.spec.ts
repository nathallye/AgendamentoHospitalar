import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HospitalCriarComponent } from './hospital-criar.component';

describe('HospitalCriarComponent', () => {
  let component: HospitalCriarComponent;
  let fixture: ComponentFixture<HospitalCriarComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HospitalCriarComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HospitalCriarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
