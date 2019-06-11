import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { AuthService } from '../_services/auth.service';


@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  @Output() cancelRegister = new EventEmitter();
  module: any = {};

  constructor(private authService: AuthService) { }

  ngOnInit() {
  }

  register() {
    this.authService.register(this.module).subscribe(() => {
      console.log('registration seccessful');
    }, error => {
      console.log(error);
    });
  }

  cancel() {
   // console.log('cancelled!!');
    this.cancelRegister.emit(false);
  }

}
