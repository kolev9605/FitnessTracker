import * as tslib_1 from "tslib";
import { Component } from '@angular/core';
import { TestItem } from 'src/app/models/test-item-model';
let TestComponent = class TestComponent {
    constructor() {
        this.testItems = [
            new TestItem(1, 'Hi'),
            new TestItem(2, 'Hi2')
        ];
    }
    ngOnInit() {
    }
    onEmmitedEvent(data) {
        console.log(data);
    }
};
TestComponent = tslib_1.__decorate([
    Component({
        selector: 'app-test',
        templateUrl: './test.component.html',
        styleUrls: ['./test.component.css']
    })
], TestComponent);
export { TestComponent };
//# sourceMappingURL=test.component.js.map