import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProfissionalExcluirComponent } from './profissional-excluir.component';

describe('ProfissionalExcluirComponent', () => {
  let component: ProfissionalExcluirComponent;
  let fixture: ComponentFixture<ProfissionalExcluirComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProfissionalExcluirComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProfissionalExcluirComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
