import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListarAgendamentoconfigComponent } from './listar-agendamentoconfig.component';

describe('ListarAgendamentoconfigComponent', () => {
  let component: ListarAgendamentoconfigComponent;
  let fixture: ComponentFixture<ListarAgendamentoconfigComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListarAgendamentoconfigComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListarAgendamentoconfigComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
