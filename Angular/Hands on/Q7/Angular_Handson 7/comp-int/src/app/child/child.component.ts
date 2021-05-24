import { Component, Input,Output,EventEmitter } from '@angular/core';

@Component({

selector: 'app-child',

template: `

Say {{ message }}

`,

styleUrls: ['./child.component.css']

})

export class ChildComponent {

@Input('childMessage') childMessage: string="";

message = 'Hello World!';


@Output() messageEvent = new EventEmitter<string>();

constructor() {}
    sendMessage() {

        this.messageEvent.emit(this.message)
 }

}