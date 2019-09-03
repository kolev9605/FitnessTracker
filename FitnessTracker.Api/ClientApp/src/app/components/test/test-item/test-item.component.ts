import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';
import { TestItem } from 'src/app/models/test-item-model';

@Component({
  selector: 'app-test-item',
  templateUrl: './test-item.component.html',
  styleUrls: ['./test-item.component.css']
})
export class TestItemComponent implements OnInit {

  @Output() emmited: EventEmitter<string> = new EventEmitter<string>();
  @Input() testItemModel: TestItem;

  constructor() { }

  ngOnInit() {
  }

  sayHello() {
    this.emmited.emit(this.testItemModel.text)
  }
}
