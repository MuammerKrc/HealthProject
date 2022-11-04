import { CategoryModel } from "./categoryModel";

export class MovieModel {
  id:number;
  title: string;
  description: string;
  categoryId: number;
  imagePath: string;
  category:CategoryModel;
}
