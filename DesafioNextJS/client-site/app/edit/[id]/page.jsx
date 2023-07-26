import EditCategory from '@/components/EditCategory'




export default async function Edit({ params}) {
  const {id} = params;
  console.log("Estou no Page pegando o ID e Chamando o Editor =", id);

  return (
    <>
      <EditCategory id={id}  /> 
    </>
  );
}
