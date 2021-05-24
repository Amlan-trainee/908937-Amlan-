import { Component,ViewChild, AfterViewInit} from '@angular/core';
import {ChildComponent } from '../child/child.component';

@Component({

selector: 'app-parent',

template: `

<app-child [childMessage]="parentMessage"></app-child>
<app-child (messageEvent)="receiveMessage($event)"></app-child>

`,

styleUrls: ['./parent.component.css']

})

export class ParentComponent implements AfterViewInit{

parentMessage = "message from parent"
@ViewChild(ChildComponent) child:any;

constructor() { }
    message:string='';

ngAfterViewInit() {

    this.message = this.child.message
    
    }
    receiveMessage($event: string) {

        this.message = $event
        
        }
}
