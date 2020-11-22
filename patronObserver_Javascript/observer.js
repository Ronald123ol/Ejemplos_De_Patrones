class Subject {
  constructor(){
    this.observers= [];
  }
  subscribe(o){
    this.observers.push(o)
  }
  unsubscribe(o){
    this.observers = this.observers.filter(e =>!o);
  }
  notify(objeto){
    this.observers.forEach(observer =>{
      observer.notify(objeto);
    })
  }
}
class TextSubject extends Subject{
  constructor(){
    super();
    this.text = "";
  }
  notify(text){
    this.text=text;
    super.notify(this);

  }
  

}
class Observer{
  notify(subject){
    document.getElementById("div1").innerHTML = subject.text;
  }
}
var textSubject = new TextSubject();
let miDiv1 = new Observer();
textSubject.subscribe(miDiv1);

document.getElementById("mitexto").addEventListener("input", (event)=>{
  textSubject.notify(event.target.value)
});