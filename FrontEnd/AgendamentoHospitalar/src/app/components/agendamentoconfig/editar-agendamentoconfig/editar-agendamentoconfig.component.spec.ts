import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditarAgendamentoconfigComponent } from './editar-agendamentoconfig.component';

describe('EditarAgendamentoconfigComponent', () => {
  let component: EditarAgendamentoconfigComponent;
  let fixture: ComponentFixture<EditarAgendamentoconfigComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditarAgendamentoconfigComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EditarAgendamentoconfigComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
