import { Component, OnInit } from '@angular/core';

import { ConfigService } from '../../services/config.service'

@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.css']
})
export class TestComponent implements OnInit {
  x: string = "Hello";

  constructor(private configService: ConfigService) { }

  ngOnInit() {
  }

  testHttp() {
    let x = this.configService.getConfig();
    console.log(x);
  }

}
