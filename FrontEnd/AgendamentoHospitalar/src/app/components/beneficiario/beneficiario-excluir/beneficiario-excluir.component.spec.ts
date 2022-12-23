import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BeneficiarioExcluirComponent } from './beneficiario-excluir.component';

describe('BeneficiarioExcluirComponent', () => {
  let component: BeneficiarioExcluirComponent;
  let fixture: ComponentFixture<BeneficiarioExcluirComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BeneficiarioExcluirComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(BeneficiarioExcluirComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
