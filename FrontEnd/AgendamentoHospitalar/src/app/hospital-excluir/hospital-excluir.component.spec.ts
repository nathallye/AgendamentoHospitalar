import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HospitalExcluirComponent } from './hospital-excluir.component';

describe('HospitalExcluirComponent', () => {
  let component: HospitalExcluirComponent;
  let fixture: ComponentFixture<HospitalExcluirComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HospitalExcluirComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HospitalExcluirComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
