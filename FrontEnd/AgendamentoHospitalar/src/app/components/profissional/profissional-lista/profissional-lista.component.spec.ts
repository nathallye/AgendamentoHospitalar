import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProfissionalListaComponent } from './profissional-lista.component';

describe('ProfissionalListaComponent', () => {
  let component: ProfissionalListaComponent;
  let fixture: ComponentFixture<ProfissionalListaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProfissionalListaComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProfissionalListaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
