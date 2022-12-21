import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetalheEspecialidadeComponent } from './detalhe-especialidade.component';

describe('DetalheEspecialidadeComponent', () => {
  let component: DetalheEspecialidadeComponent;
  let fixture: ComponentFixture<DetalheEspecialidadeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DetalheEspecialidadeComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DetalheEspecialidadeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
