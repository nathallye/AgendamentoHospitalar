import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProfissionalEditarComponent } from './profissional-editar.component';

describe('ProfissionalEditarComponent', () => {
  let component: ProfissionalEditarComponent;
  let fixture: ComponentFixture<ProfissionalEditarComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProfissionalEditarComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProfissionalEditarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
