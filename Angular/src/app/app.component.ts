import {
  Component
} from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})

export class AppComponent {
  pelajaran = 'Pemrograman Framework'

  GantiMatkul(){
    this.pelajaran = 'Pemrograman Visual'
  }
}
