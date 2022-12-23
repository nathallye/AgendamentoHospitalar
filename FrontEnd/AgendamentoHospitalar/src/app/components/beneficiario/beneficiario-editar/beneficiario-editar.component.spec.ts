import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BeneficiarioEditarComponent } from './beneficiario-editar.component';

describe('BeneficiarioEditarComponent', () => {
  let component: BeneficiarioEditarComponent;
  let fixture: ComponentFixture<BeneficiarioEditarComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BeneficiarioEditarComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(BeneficiarioEditarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
