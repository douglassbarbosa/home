import EditCategory from '@/components/EditCategory'
import CategoryList from '@/components/CategoryList'




export default async function Edit({ params}) {
  const {id} = params;
  console.log("Estou no Page pegando o ID e Chamando o Editor =", id);

  return (
    <>
      <EditCategory id={id}  />      
      <CategoryList />
    </>
  );
}
