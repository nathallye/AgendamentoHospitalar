import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ExcluirEspecialidadeComponent } from './excluir-especialidade.component';

describe('ExcluirEspecialidadeComponent', () => {
  let component: ExcluirEspecialidadeComponent;
  let fixture: ComponentFixture<ExcluirEspecialidadeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ExcluirEspecialidadeComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ExcluirEspecialidadeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
