function Input({ height, width, typeI }) {
  return (
    <input
      type={typeI}
      style={{ 
        height: height, 
        width: width 
    }}
    />
  );
}



export default Input ()