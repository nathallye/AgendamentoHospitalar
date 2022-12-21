import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BeneficiarioCriarComponent } from './beneficiario-criar.component';

describe('BeneficiarioCriarComponent', () => {
  let component: BeneficiarioCriarComponent;
  let fixture: ComponentFixture<BeneficiarioCriarComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BeneficiarioCriarComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(BeneficiarioCriarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
