import { Component, OnInit } from '@angular/core';
import {FormGroup,FormControl,FormBuilder, Validators} from '@angular/forms';

@Component({
  selector: 'app-edit-emp-reactive',
  templateUrl: './edit-emp-reactive.component.html',
  styleUrls: ['./edit-emp-reactive.component.css']
})
export class EditEmpReactiveComponent implements OnInit {
  frm:FormGroup;
  departments:any=[]

  constructor(private formBuilder:FormBuilder) {
     this.frm=formBuilder.group({
      name : ['',Validators.required,
      Validators.minLength(4),
      Validators.maxLength(20)],
      skill :['',Validators.required],
      department :['',Validators.required],
      salary :['',Validators.required],
      permanent:['',Validators.required]
       });
   }
  ngOnInit(): void {}
  postData(){
    console.log(this.frm.value);
  }
}

