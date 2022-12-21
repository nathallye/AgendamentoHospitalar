import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AgendamentoCriarComponent } from './agendamento-criar.component';

describe('AgendamentoCriarComponent', () => {
  let component: AgendamentoCriarComponent;
  let fixture: ComponentFixture<AgendamentoCriarComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AgendamentoCriarComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AgendamentoCriarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
