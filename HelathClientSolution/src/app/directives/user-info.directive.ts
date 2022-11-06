import { ThisReceiver } from '@angular/compiler';
import { Directive, ElementRef, HostListener, Renderer2 } from '@angular/core';
import { CustomToastService } from '../services/common/custom-toast.service';

@Directive({
  selector: '[userInfoDirectiveElement]'
})
export class UserInfoDirective {

  constructor(
    private elementRef: ElementRef,
    private renderer: Renderer2,
    private toastService: CustomToastService) {
      var element: HTMLElement = this.renderer.createElement("div");
      element.classList.add("setting-area");
      this.renderer.appendChild(this.elementRef.nativeElement.parentElement.parentElement, element);
    }

  makeElement() {

  }

  @HostListener('click')
  onClick() {
    var elementss: HTMLElement = this.renderer.createElement("div");
    elementss.classList.add("setting-area");
    var y:HTMLElement=this.renderer.createElement("h3");
    var br:HTMLElement=this.renderer.createElement("hr");
    y.innerHTML="Selam";
    y.addEventListener("click",x=>{
      console.log("deneme");
    });
    elementss.appendChild(y);
    elementss.appendChild(br);

    this.renderer.appendChild(this.elementRef.nativeElement.parentElement.parentElement, elementss);

  }
}
