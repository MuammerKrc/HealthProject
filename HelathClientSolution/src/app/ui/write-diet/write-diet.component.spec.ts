import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WriteDietComponent } from './write-diet.component';

describe('WriteDietComponent', () => {
  let component: WriteDietComponent;
  let fixture: ComponentFixture<WriteDietComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WriteDietComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(WriteDietComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
