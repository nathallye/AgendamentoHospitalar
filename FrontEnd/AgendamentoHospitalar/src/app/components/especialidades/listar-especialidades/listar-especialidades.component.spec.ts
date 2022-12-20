import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListarEspecialidadesComponent } from './listar-especialidades.component';

describe('ListarEspecialidadesComponent', () => {
  let component: ListarEspecialidadesComponent;
  let fixture: ComponentFixture<ListarEspecialidadesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListarEspecialidadesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListarEspecialidadesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
