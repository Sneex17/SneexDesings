export interface cuerpoDesign {
  productdesignid: string;
  title: string;
  description: string;
  category: string;
  img: string;
  fecha: Date;
}


export async function Listar() {
  const response = await fetch('/design/lista');    
  if (!response.ok) {
    throw new Error(`HTTP error ${response.status}`);
  }
  const data = await response.json() as cuerpoDesign[];
  return data;
}
